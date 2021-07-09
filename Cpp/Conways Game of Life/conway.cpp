#include <iostream>
#include <vector>

using namespace std;

class Conway
{
    
    public:
    
        vector<char> vec;
        int size;
        
        void updateBoard()
        {
            //system("cls");
            for(int i = 0; i < size; i++)
            {
                cout << vec.at(i);
                if( (i + 1) % size == 0 )
                {
                    cout << endl;
                }
            }
        }

        void mainLoop()
        {
            //while(true)
            //{
            updateBoard();
            //}
        }

        Conway(int Size)
        {
            size = Size * Size;

            for(int i = 0; i < size; i++)
            {
                vec.push_back(0);
            }
            //fill(vec.begin(), vec.end(), 0);
        }

        ~Conway()
        {
            
        }

};