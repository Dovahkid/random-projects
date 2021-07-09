#include <SFML/Window.hpp>
#include <SFML/System.hpp>
#include <SFML/Graphics.hpp>

#include <vector>

#include <iostream>

using namespace sf;
using std::string;
using std::vector;
using std::cout;
using std::endl;

class snake {
public:
	char lastKey;
	int x;
	int y;

	void direction() {
		switch (lastKey) {
		case 'w':
			y -= 1;
			break;
		case 's':
			y += 1;
			break;
		case 'a':
			x -= 1;
			break;
		case 'd':
			x += 1;
			break;
		default:
			break;
		
		}
	}

};


int main() {

	RenderWindow gameWindow(VideoMode(800, 800), "Game Window");
	gameWindow.setFramerateLimit(60);

	CircleShape snake1Head(3.0f);
	snake1Head.setFillColor(Color(0, 150, 255));
	snake snake1;
	snake1.x = 400;
	snake1.y = 400;
	snake1.lastKey = 'w';

	while (gameWindow.isOpen()) {

		Event event;
		while (gameWindow.pollEvent(event)) {

			switch (event.type) {
			case Event::Closed:
				gameWindow.close();
				break;

			case Event::KeyPressed:
				if (Keyboard::isKeyPressed(Keyboard::Escape)) {
					gameWindow.close();
					break;
				}
			case Event::TextEntered:
				if ((event.text.unicode == 'w' && snake1.lastKey != 's') 
					|| (event.text.unicode == 'a' && snake1.lastKey != 'd') 
					|| (event.text.unicode == 's' && snake1.lastKey != 'w') 
					|| (event.text.unicode == 'd' && snake1.lastKey != 'a')) 
				{
					snake1.lastKey = event.text.unicode;
				}
					
			default:
				break;
			}

		}

		snake1.direction();
		snake1Head.setPosition(snake1.x, snake1.y);

		gameWindow.clear();
		gameWindow.draw(snake1Head);
		gameWindow.display();
	}

	return 0;
}
