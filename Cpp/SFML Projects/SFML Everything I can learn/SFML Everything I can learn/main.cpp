#include <SFML/Window.hpp>
#include <SFML/Graphics.hpp>

#include <iostream>

using namespace sf;

int main() {

	RenderWindow gameWindow(VideoMode(1000, 800), "New Game window", Style::Resize);
	//gameWindow.setVerticalSyncEnabled(true); // forces application to run at monitor refresh rate
	gameWindow.setFramerateLimit(1000000000000000); // sets framerate limit to a number, 75 in this case
	//This method may be unreliable for precise timing

	// if you want to create the window after construction do function
	// gameWindow.create(...);

	gameWindow.setMouseCursorGrabbed(false);
	gameWindow.setMouseCursorVisible(false);

	Texture spriteSheet;
	spriteSheet.loadFromFile("sprite1.png");

	Sprite sprite1;
	sprite1.setTexture(spriteSheet); // this will use the entire sheet as the sprite
	//sprite1.setTextureRect(IntRect(0,0,16,16); // not working for some reason

	sprite1.setPosition(Vector2f(10,10));

	//creates the texture obj
	Texture crosshair;
	//texture.loadFromFile("wood.png");
	crosshair.loadFromFile("crosshair.png"); // loads a texture to the object

	//CircleShape shape(100.0f);
	RectangleShape cross(Vector2f(100.0f, 100.0f)); //creates shape
	cross.setTexture(&crosshair); // applies the texture to the shape

	/*
	ConvexShape shape;
	shape.setPointCount(3);
	shape.setPoint(0, Vector2f(0.0f, 0.0f));
	shape.setPoint(1, Vector2f(25.0f, 55.0f));
	shape.setPoint(2, Vector2f(55.0f, 25.0f));
	*/

	/*
	shape.setFillColor(Color(0, 100, 255));
	shape.setTexture(&texture);
	shape.setOutlineColor(Color(255, 0, 100));
	shape.setOutlineThickness(5.f);
	*/


	//Runs the program as long as the window is open
	while (gameWindow.isOpen()) {

		//yLoc += 0.5;
		//xLoc += 0.5;

		//shape.setPosition(xLoc, yLoc);

		Event events;
		while (gameWindow.pollEvent(events)) {
		
			switch (events.type) {
				case Event::Closed:
					gameWindow.close();
					break;
				
				case Event::KeyPressed:
					if (Keyboard::isKeyPressed(Keyboard::Escape)) {
						gameWindow.close();
					}
				
				/*
				case Event::MouseButtonPressed:
					shape.setPosition(events.mouseButton.x, events.mouseButton.y);
					break;
				*/
				
				case Event::MouseMoved:
					std::cout << "mouse x: " << events.mouseMove.x << std::endl;
					std::cout << "mouse y: " << events.mouseMove.y << std::endl;
					//shape.setPosition(events.mouseMove.x - 100, events.mouseMove.y - 100);
					cross.setPosition(events.mouseMove.x-50, events.mouseMove.y-50);
					break;
					

					/*
				case Event::TextEntered:
					if (events.text.unicode == 'a') {
						std::cout << "A" << std::endl;
					}
					break;

				case Event::KeyPressed:
						gameWindow.setSize(Vector2u(100, 120));
					break;

				case Event::Resized:
					std::cout << "new height: " << events.size.height << std::endl;
					std::cout << "new width: " << events.size.width << std::endl;
					break;

				case Event::LostFocus:
					std::cout << "lost focus" << std::endl;
					break;
				case Event::GainedFocus:
					std::cout << "gained focus" << std::endl;
					break;
					*/

				default:
					break;
			}
		}
	
		gameWindow.clear();
		gameWindow.draw(cross);
		gameWindow.draw(sprite1);
		gameWindow.display();

	}


	return 0;
}