# EZImGUILib
Easy to use ImGUI library that adds object orientation.

## Why should I use it?
ImGUI.NET has a very weird way of rendering GUIs. It has a habit of using static methods between a begin and an end function. This works but it can get out of hand fast. Your code will get cluttered and it will be hard to find things. It's also just overall hard to read. This library is a great choice to clean up your ImGUI code in a more practical manner.

### Vanilla ImGUI:
```cs
public void render() {
  ImGUI.Begin();
  if (ImGUI.Button("I'm a button!") {
    Console.WriteLine("You pressed the button!");
  }
  ImGUI.End();
}
```

### ImGUI.NET with EZImGUILib:
```cs
public class MyGUI : GUI {
  private Button myButton;
  
  public MyGUI("My Awesome GUI!") {
    myButton = new Button("I'm a button!");
    
    events();
    
    addComponent("myButton", myButton);
  }
  
  public void events() {
    myButton.onClick += (sender, e) => {
      Console.WriteLine("You pressed the button!");
    };
  }
}
```
This example shows better practice for writing code, it doesn't use static functions to add controls, you can create separate button instances and give them their own event handlers as opposed to writing tons of if statements.

## How to Use
Add the compiled DLL to your project's references. The GUI class can be extended to create premade GUI classes. Call the render function every frame. Construct the GUI anywhere, it's recommended that you use a GUI manager to easily open and hide GUIs. 
