CommandPattern
===================================
### Example
Command pattern case from book "Head First Design Pattern"

### Code repository
https://github.com/Johnjunzhang/CommandPattern

### Content
####Step 1
#####Motivation:
Bad Smell: Divergent Change

#####Intent
Encapsulate a request as a object

#####Mechanics
1. Extract Method: Extract light.On() to LightOn method in RemoteControl.cs
2. Create file from template: Generate class LightOnCommand
3. Move Method:
   * Generate Code: Generate constructor with Light parameter in LightOnCommand.cs
   * Introduce and initialize filed 'light'
   * Make field 'light' public
   * Introduce variable: add new LightOnCommand(light) in LightOn method in RemoteControl.cs
   * Use lightOnCommand.light.On() to replace with light.On()
   * Introduce parameter: lightOnCommand
   * Make 'LightOn' static
   * Make 'LightOn' Method Non-Static with Visibility 'public'
   * Inline lightOnCommand and remove redundant qualifier:this.
   * Make field "light" private
4. Use 1-3 to extract CeilingHighCommand class
5. Use 1-3 to extract StereoOnCommand class
6. Use 1-3 to extract LightOffCommand class
7. Use 1-3 to extract CeilingOffCommand class
8. Use 1-3 to extract StereoOffCommand class

#####Result
git checkout step1

####Step 2
#####Motivation
Bad Smell: Alternative Classes with Different Interfaces

#####Intent
Make requests with same interface

#####Mechanics
1. Rename: LightOn, LightOff, CeilingHigh, CeilingOff, StereoOn, StereoOff to Execute
2. Extract Interface: Extract ICommand from LightOnCommand with Execute method.
3. Let other Commands to inherit ICommand interface.

#####Result
git checkout step2

####Step 3
#####Motivation
Bad Smell: Switch Statements

#####Intent   
Map the receiver with the action

#####Mechanics
1. Introduce variable: lightOnCommand, CeilingHighCommand, StereoOnCommand in RemoteControl.cs
2. New Dictionary<int, ICommand>(), Introduce field: onCommands
3. commands.Add(1, lightOnCommand)
4. Use commands[slot].Execute() to replace lightOnCommand.Execute()
5. Use 3-4 to replace ceilingHighCommand.Execute()
6. Use 3-4 to replace stereoOnCommand.Execute()
7. Remove If conditions
8. Use 1-7 to refactoring Off method

#####Result
git checkout step3

####Step 4
#####Motivation
Bad Smell: Functions Should Do One Thing

#####Intent
Decouple instantiate command from execution request

#####Mechanics
1. Extract Method: Extract commands initialize to 'GetOnCommands' method in RemoteControl.cs
2. Introduce Field: Introduce field 'getOnCommands' and initialize in Constructor(s)
3. Inline Field: onCommands
4. Use 1-3 to refactoring Off method

#####Result
git checkout step4

####Step 5
#####Motivation
Bad Smell: Primitive Obsession

#####Intent
Use user defined method to replace dictionary add

#####Mechanics
1. Introduce Filed: Introduce 'onCommands' and initialize in Field initializer
2. Extract Method: Extract add lightOnCommand to SetOnCommand method
3. Introduce Parameter: Introduce slot number 1 to parameter
4. Use SetOnCommand for add ceiling and stereo
5. Use 1-4 to refactoring Off method.

#####Result
git checkout step5

####Step 6
#####Motivation
Bad Smell: Temporary Field

#####Intent
Remove temporary field

#####Mechanics
1. Inline Method: GetOnCommands()
2. Inline Field: getOnCommands
3. Use 1-2 to remove getOffCommands
4. Inline Field: light, ceiling, stereo

#####Result
git checkout step6

####Step 7
#####Motivation
Bad Smell: Divergent Change

#####Intent
Parameterize clients with different request

#####Mechanics
1. Replace Constructor With Factory Method
2. Extract Method: Extract codes in constructor to SetCommands method
3. Introduce Variable: remoteControl in factory method
4. Use remoteControl.SetCommands method in factory method to replace SetCommands in constructor
5. Safe Delete: parameters and its constructor
6. Inline Method: SetCommands()
7. Change SetOnCommand to public
8. Change SetOffCommand to public
9. Inline Method: Inline CreateRemoteControl factory method
10. Remove useless SetOnCommand, SetOffCommand calls in RemoteControlFact 

#####Result
git checkout step7

###Further Exercises
1. Read the "Refactoring" book about the bad smells and mechanics have been used. This is the website version of the book for quick reference: http://sourcemaking.com/refactoring
2. Implement 'Null Object' for dealing with unset slot gracefully.
3. Implement Undo function for understanding more about benefit from Command Pattern.
4. Implement Macro function for understanding more about benefit from Command Pattern. 
