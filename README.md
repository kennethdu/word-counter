# _Word Counter_

#### _Friday Independent Project for Epicdous, 9.14.2018_

#### By _**Kenneth Du**_

## Description

_.Demonstrations of Basic MVC Apps with proper routing and functionality. It has three examples from previous work done, such as: word counter, leap year checker, and parcel calculator._

## Setup/Installation Requirements

* Clone this repository
* Navigate to the WordCounter.Solution/WordCounter directory
* In a c# compiler (I suggest mono) type 'dotnet run' to run a local host
* In a web browser, navigate to 'http://localhost:5000/'
* The program will allow the user to choose between: word counter, leap year checker, and parcel calculaotr

## Specifications

### Specs: Word Counter
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **The program will identify a single string** | Input: "dog" | Output: "dog" |
| **The program will identify a sentence of strings** | Input: "My dog is the best dog" | Output: "My dog is the best dog"|
| **The program will return the amount of times the word is repeated in the sentence** | Input: "My dog is the best dog" | Output: "2" |
### Specs: Leap Year Checker 
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **The program will identify a year** | Input: "2000" | Output: "2000" |
| **The program will check if the year is a leap year** | Input: "2000" | Output: "true"|
| **The program will check if the year is a leap year** | Input: "2001" | Output: "false"|
### Specs: Parcel Calculator 
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **The program will identify a users input of length, width, heighth, and weight** | Input: "2 2 2 23" | Output: "2 2 2 23" |
| **The program will calculate the cost of the parcel** | Input: "2 2 2 23" | Output: "$33"|
| **The program will return the users cost to ship, volume, and weight** | Input: "2 2 2 23" | Output: "$33 8 23" |

## Known Bugs

_The leap year checker does not take a proper input in the model in the method of IsLeapYear()._

## Support and contact details

_kennethdu3@gmail.com_

## Technologies Used

_C#/.Net Core 1.1_
_Atom_
_Mono_
_Git_
_Github_
_HTML_

### License

This software is licensed under the MIT license.

Copyright (c) 2018 **_Kenneth_Du_**
