package tictactoe;

import java.util.Arrays;

public class TicTacToe {

    public TicTacToe(){

        Arrays.fill(board, ' ');

    }

    private char[] board = new char[9];

    public void gameLoop(){

    }

    // Returns board array
    public char[] getBoardInfo(){
        return board;
    }

    // Function that calls others to update board info
    private boolean setBoardInfo(int index, char newVal){ // returns true if the board update was successful
        if(validateMove(index)){
            board[index] = newVal;
            return true;
        }
        else{
            return false;
        }
    }

    private boolean validateMove(int index){ // Validates that a player's choice is not overwriting a previous choice
        // Returns false if its an invalid move
        // Invalid moves are any moves that overwrite a previous move
        return !(board[index] != 'x' && board[index] != 'o');
    }

    private boolean xWinCheck() {

        if (
                (board[0] == 'x' && board[0] == board[1] && board[0] == board[2]) ||
                        (board[0] == 'x' && board[0] == board[3] && board[0] == board[6]) ||
                        (board[0] == 'x' && board[0] == board[4] && board[0] == board[8]) ||
                        (board[3] == 'x' && board[3] == board[4] && board[3] == board[5]) ||
                        (board[1] == 'x' && board[1] == board[4] && board[1] == board[7]) ||
                        (board[2] == 'x' && board[2] == board[5] && board[2] == board[8]) ||
                        (board[2] == 'x' && board[2] == board[4] && board[2] == board[6]) ||
                        (board[6] == 'x' && board[6] == board[7] && board[6] == board[8])
        ) {
            return true;
        }
        return false;
    }

    private boolean oWinCheck(){
        if (
                (board[0] == 'o' && board[0] == board[1] && board[0] == board[2]) ||
                        (board[0] == 'o' && board[0] == board[3] && board[0] == board[6]) ||
                        (board[0] == 'o' && board[0] == board[4] && board[0] == board[8]) ||
                        (board[3] == 'o' && board[3] == board[4] && board[3] == board[5]) ||
                        (board[1] == 'o' && board[1] == board[4] && board[1] == board[7]) ||
                        (board[2] == 'o' && board[2] == board[5] && board[2] == board[8]) ||
                        (board[2] == 'o' && board[2] == board[4] && board[2] == board[6]) ||
                        (board[6] == 'o' && board[6] == board[7] && board[6] == board[8])
        ) {
            return true;
        }
        return false;
    }

    private void userInput(int index, char newVal){



    }

}
