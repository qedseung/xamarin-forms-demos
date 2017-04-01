# Xamarin Forms Demos

This project demonstrates:
1. how to implement a timer
2. how to use static methods to access native API e.g. vibration. 
3. how to display an alert (blocking)
4. how to display an Action Sheet (non-blocking/async)
5. how to connect button clicked event

(Vibration was successfully tested on a Samsung Galaxy S4, but not yet tested on iOS device.)

Other functionality may be added in the future.

### Getting Started
Download this project and open the solution in Xamarin Studio or Visual Studio.
Most functionality lies in the GreetPage.xaml.cs file and UI elements are implemented in the GreetPage.xaml file. Edit these files for desired effects.

### Abstraction of Native API
An event is exposed from the underlying page, the event is connected to a method which invokes an action. That action is then set to equal to a function in MainActivity.cs(Android) and AppDelegate.cs(iOS) that utilizes the desired native API. (There are better ways to do this, such as dependency injection, but this is the simplest/quickest from my perspective especially if you only want to access one function)

### Android Vibration
Include this line in the AndroidManifest.xml ` <uses-permission android:name="android.permission.VIBRATE" /> ` to allow for vibrations from the app. In Xamarin Studio, this should appear as a checkbox and one simply needs to check the Vibrate option.
