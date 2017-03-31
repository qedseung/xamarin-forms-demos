# Xamarin Forms Demos

This project demonstrates how to implement a timer, how to implement events, how to display alerts, and how to use static methods to access native API e.g. vibration.

Vibration was successfully tested on a Samsung Galaxy S4, but not yet tested on iOS device.

Other functionality may be added in the future.

### Where to Start
Download this project and open the solution in Xamarin Studio or Visual Studio.
Most functionality lies in the GreetPage.xaml.cs file and UI elements are implemented in the GreetPage.xaml file. Edit these files for desired effects.

### Abstraction of Native API
An event is exposed from the underlying page, the event is connected to a method which invokes an action. That action is then set to equal ro a function in MainActivity.cs(Android) and AppDelegate.cs(iOS) that utilizes the desired native API.
