import os

#---------------------------------------------------#
#
# Want to make this work in either the command line 
# or in a GUI
# Would like to create a GUI to draw game boards 
# to save them to JSON files that can be loaded here
# and displayed
#
#---------------------------------------------------#



class ConwaysGameOfLife:
    def __init__(self, Size, Empty_Space, Populated_Space):
        
        self.empty_space = Empty_Space
        self.populated_space = Populated_Space

        self.size = Size
        #self.board = [[self.empty_space] * self.size] * self.size # init board to all dead/empty spaces
        # at some point this should be replaced with loading from a JSON file

        self.board = [ # as terrible as this looks its for testing
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.populated_space,self.populated_space,self.populated_space,self.populated_space,self.populated_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space],
            [ self.empty_space, self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space,self.empty_space]
        ]

        #--------------------------------#
        #
        # ive discovered this doesnt work...
        #
        #
        #
        #
        #--------------------------------#

        print(len(self.board))
        print(len(self.board[6]))

    def Update(self): # Updates the array that holds the board information
            for i, row in enumerate(self.board):
                for j, space in enumerate(row):
                    cell_index = { # loops go through all spaces in a 2D list of N*N size
                        "row": i,
                        "column": j
                    }

                    surrounding_cells = self.__get_surrounding_cells(cell_index)
                    board_space = self.board[cell_index["row"]][cell_index["column"]]

                    if board_space == self.populated_space:
                        if not surrounding_cells in [2, 3]: # if surrounding cells does not contain either 2 or 3 living cells then the living cell will die
                            board_space = self.empty_space
                    else:
                        if surrounding_cells == 3: # if a dead cell has 3 living cells the dead cell becomes a living cell
                            board_space = self.populated_space


    def __get_surrounding_cells(self, cell_index): # Gets the 8 cells around a particular cell. Returns number of living cells
        count = 0
        for i in range(8): # * because that is the maximum amount of surrounding cells
            
            # if cell_index["row"] != 0: # if it is 0 then it is the top row and does not have a row to check above it
            #     pass
                
            # if cell_index["column"] != 0: # if it is 0 then it is the left most column and does not have a column to check left of it
            #     pass

            # if cell_index["row"] != self.size-1: # if it is {size} then it is the bottom row and does not have a row to check below it
            #     pass
                
            # if cell_index["column"] != self.size-1: # if it is {size} then it is the right most column and does not have a column to check right of it
            #     pass

            try:
                if (self.__cell_math(-1, -1)):
                    count += 1
                if (self.__cell_math(-1, 0)):
                    count += 1
                if (self.__cell_math(-1, 1)):
                    count += 1
                if (self.__cell_math(0, -1)):
                    count += 1
                if (self.__cell_math(0, 1)):
                    count += 1
                if (self.__cell_math(1, -1)):
                    count += 1
                if (self.__cell_math(1, 0)):
                    count += 1
                if (self.__cell_math(1, 1)):
                    count += 1

            except Exception as ex:
                pass

        def __cell_math(self, row, column):
            if self.board[cell_index["row"] + row]["column"] + column == self.populated_space:
                return True
            return False



    def CLIStart(self): # Used for displaying in the command line
        while(True): # This needs to have a way to terminate eventually. Will add later
            self.Update()
            self.__CLIBoard()


    def __CLIBoard(self): # Displays the board to the screen
        os.system("cls")
        for i, row in enumerate(self.board): # Loops through all elements in a 2D array of N*N size
            for j, space in enumerate(row):
                print(f"{space} ", end="")
            print()


if __name__ == "__main__":
    con = ConwaysGameOfLife(15, '.', 'O')

    con.CLIStart()