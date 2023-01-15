# SentenceCase
  This is a dotnet package that formats a string to sentence case as used in names.
## Installation 
 + Install the package by running `dotnet add package StringFormatter-c4 --version 1.0.0` on your dotnet CLI
 + You can also install by the following steps: 
    - Right-click on your dependences 
    - Select manage nuget packages
    - Search for StringFormatter-c4 
    - Click on install
    
 ## Using the package
 The snippet below will help you in using the package
  ```
  using StringFormatter-c4;
  
  internal class NameDisplay {
  
  private void DisplayName(){
  Formatter.ToSentenceCase("adams");
  
  //Returns Adams  
    }
  }
  ```
