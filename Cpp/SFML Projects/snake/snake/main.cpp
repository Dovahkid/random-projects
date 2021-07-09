/*

Comments and reminders at bottom of file

*/

#include "headers.h"
#include "snake.h"




/*
if (events.text.unicode == 'w' && snake1.lastKey != 's') {
	snake1.lastKey = 'w';
	//snake1.y -= 1;
	//break;
}
*/


int main() {

	RenderWindow gameWindow(VideoMode(800, 800), "Snake Game", Style::Titlebar);
	
	gameWindow.setFramerateLimit(60);

	Event events;

	Texture backgroundTexture;
	backgroundTexture.loadFromFile("textures/background.png");
	
	RectangleShape background(Vector2f(800.0f, 800.0f));
	background.setTexture(&backgroundTexture);
	background.setPosition(Vector2f(0, 0));
	
	Texture snakeBit;
	snakeBit.loadFromFile("textures/snakeSegment.png");

	Sprite snakeHead;
	snakeHead.setTexture(snakeBit);
	snakeHead.setPosition(Vector2f(400.0f, 400.0f));

	Sprite snakeHead2;
	snakeHead2.setTexture(snakeBit);
	snakeHead2.setPosition(Vector2f(500.0f, 400.0f));

	Text scoreText;


	/*
	snake snake1;
	snake1.bodyLoc.push_back(vector<int>());
	snake1.bodyLoc.push_back(vector<int>());

	snake1.y = 0;
	snake1.x = 1;

	snake1.bodyLoc[1].push_back(1); //y
	snake1.bodyLoc[0].push_back(2); //x

	snake1.bodyLoc[1].push_back(0); //y
	snake1.bodyLoc[0].push_back(1); //x

	snake1.bodyLoc[1].push_back(1); //y
	snake1.bodyLoc[0].push_back(2); //x

	cout << snake1.collisionCheck() << endl;
	*/

	snake snake1;
	snake1.lastKey = 'w';
	snake1.x = 400;
	snake1.y = 400;

	snake snake2;
	snake2.lastKey = '8';
	snake2.x = 500;
	snake2.y = 400;

	snake1.bodyLoc.push_back(vector<int>());
	snake1.bodyLoc.push_back(vector<int>());


	while (gameWindow.isOpen()) {
		snake1.direction();
		snake2.direction();
		snakeHead.setPosition(snake1.x, snake1.y);
		snakeHead2.setPosition(snake2.x, snake2.y);

		/*
		if (snake1.collisionCheck() == true) {
			gameWindow.close();
		}
		*/

		while (gameWindow.pollEvent(events)) {
			switch (events.type) {

			case Event::KeyPressed:
				if (Keyboard::isKeyPressed(Keyboard::Escape)) {
					gameWindow.close();
					break;
				}
				break;

			case Event::TextEntered:
				while (Keyboard::isKeyPressed(Keyboard::M) && !Event::KeyReleased) { // I dont know why this loop allows for all keys to be held... because it shouldn't as to my knowledge
					//snake1.y -= 1;
				}
				//Snake 1
				if (events.text.unicode == 'w' && snake1.lastKey != 's') {
					snake1.lastKey = 'w';
					//snake1.y -= 1;
					//break;
				}
				else if (events.text.unicode == 'a' && snake1.lastKey != 'd') {
					snake1.lastKey = 'a';
					//snake1.x -= 1;
					//break;
				}
				else if (events.text.unicode == 's' && snake1.lastKey != 'w') {
					snake1.lastKey = 's';
					//snake1.y += 1;
					//break;
				}
				else if (events.text.unicode == 'd' && snake1.lastKey != 'a') {
					snake1.lastKey = 'd';
					//snake1.x += 1;
					//break;
				}

				 //Snake 2
				if (events.text.unicode == '8' && snake2.lastKey != '2') {
					snake2.lastKey = '8';
					//snake1.y -= 1;
					//break;
				}
				else if (events.text.unicode == '4' && snake2.lastKey != '6') {
					snake2.lastKey = '4';
					//snake1.x -= 1;
					//break;
				}
				else if (events.text.unicode == '2' && snake2.lastKey != '2') {
					snake2.lastKey = '2';
					//snake1.y += 1;
					//break;
				}
				else if (events.text.unicode == '6' && snake2.lastKey != '4') {
					snake2.lastKey = '6';
					//snake1.x += 1;
					//break;
				}
				break;
			}
		}
		


		gameWindow.clear();
		gameWindow.draw(background);
		gameWindow.draw(snakeHead);
		gameWindow.draw(snakeHead2);
		gameWindow.display();
	}

	
	return 0;
}





/*



	Need to add the trail to the snake
		Need to make it follow the head correctly
	Need to fix the head and body to comply with the class better
	Need to start the body with a size so it doesn't immediately 
		throw an exception because the vector is empty and subtracting from nothing is not possible



*/
