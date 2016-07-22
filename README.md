# _word-counter_

#### _Interactive application, that that allows user to input a string of words in field one, and a search word in field two.  The program will identify how many times the word in field two appears in field one._

#### By _**Rick Thornbrugh.**_

## Description

_User starts at the index page.  There are two inputs.  Input one is the sentence string input.  Field two is the search word input.  The user inputs multiple words(sentence, or paragraph) into field one.  The user will then input a single word(search term) in field two, and push the submit button.  The user is taken to a results page that displays the number of times that the search term from field two appears in the word string of field one._

## Setup/Installation Requirements

_File can be cloned from Github @ [https://github.com/Rick1970/word-counter].
Created in C# with atom text editor.  Used Nancy framework, and razor view engine.  To run the file after download; run the kestrel server by typing dnx kestrel._

## Specifications
| Behavior | Input Example | Output Example |
| ------------- |:-------------:| -----:|
|User inputs the letter "a" into field one | "a" | input is collected
|The test will verify that the Getter is working.|
|User inputs the letter "a" into field two | "a" | input is collected
|The test will verify that the Getter is working for field two|
|User inputs new character into field 1, 2 | "b" | new input is collected
|The test will verify that the setter is working|
|User data is saved for evaluation for field one, and two | "a", "a" |"a", "a" saved |
|The test will verify that the save function is working|
|User inputs "a" into field one, and "a" into field two, and hits submit| "a" | 1|
|This test will verify that a comparison is being made between field one, and field two; and a correct result of 1 is the output|
|User inputs a single, longer word in field one, and two.| "cat" | 1 |
|The test will verify that the function still works with longer word|
|User inputs two of the same words in field one; and the same word in field two|"cat cat" & "cat"| 2 |
|The test will verify that the function works with multiple instances of the word|
|User inputs two different words in field one, and a single matching word in field two | "cat dog" & "cat" | 1 |
|Test will verify that the function can identify, and calculate for correct matches only |
|User inputs a full sentence into field one, and a single search word in field two | "The weather is nice today." & "is" | 1 |
|Test will verify that the function can correctly sort and calculate matchs only|
|User inputs a sentence with some capital words, and a noncap match | "My name is Rick." & "rick" | 1 |
|Test will verify that the function is able to locate the match with, or without caps |


## Known Bugs

_None known._

## Support and contact details

_Contact the author at [rthornbrug@gmail.com]._

## Technologies Used

_Atom text editor, in C#, with Nancy framework and razor view engine, running on Kestrel server._

### License

*MIT License

*Copyright (c) [2016]
