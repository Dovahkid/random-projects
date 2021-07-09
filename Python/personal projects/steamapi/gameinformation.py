import requests
import json
import os


KEY = '7A5A70C3B0BEED0A64104AAE4582E912'
steamID = '76561198121679447'


def isFileEmpty(ownedGames):
    try:
        if os.stat(ownedGames).st_size == 0:
            return True
        return False
    except:
        return True


def getOwnedGames():
    ownedGames = 'owned_games.json' 
    info = {}

    if isFileEmpty(ownedGames):
        req = requests.get('http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=' + KEY + '&steamid=' + steamID +'&format=json').json()
        info = req
        with open(ownedGames, 'w') as ownedGamesJson:
            json.dump(info, ownedGamesJson, indent=4)

    with open(ownedGames, 'r') as gamesJson:
        info = json.load(gamesJson)

    gamesList = info['response']['games']

    return gamesList


def getGameInfo(gamesList):
    gamesRequest = ''
    gameInfoList = {}
    gameInfoList['games'] = []
    tempObj = {}
    
    for i in range(len(gamesList)):
        appid = str(gamesList[i]['appid'])
        gamesRequest = requests.get('http://api.steampowered.com/ISteamUserStats/GetSchemaForGame/v2/?key=' + KEY + '&appid=' + appid).json()
        gamePlayTime = gamesList[i]['playtime_forever'] / 60

        try:
            gameName = gamesRequest['game']['gameName']

            if gameName == "":
                raise Exception()
        except:
            gameName = 'No Name Found'

        tempObj = {'appid': appid, 'name': gameName, 'playtime': gamePlayTime}
        gameInfoList['games'].append(tempObj)

        print(f'{i+1}/{len(gamesList)}')

    with open('games.json', 'w') as gamesJson:
        json.dump(gameInfoList, gamesJson, indent=4)


if __name__ == '__main__':
    gamesList = getOwnedGames()
    getGameInfo(gamesList)
