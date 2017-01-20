# Purpose
Since DreamTeam Dive is a open source team project, code formatting is a vital part of the development process to make it easier to read, and modify.

### Declarations
  * Every function should have a summary tag explaining it in more details.
  * Variables and functions should be named according to the [lower camel case](https://en.wikipedia.org/wiki/Camel_case) standard.
  * If a comment is needed near a *variable* declaration, they should be beside the initial variable.
  * Variable declaration is limited to a single declaration per row.
  * Accessibility Levels should be written in the following order:
    1. private
    2. protected
    3. public 
  * Example declaration below:
    ```csharp
    void functionName() 
    {
        private int id;
        private int age;
        private bool isVerified;
        protected string name;
        public int number;
        
        private void verifyUser();
        public void addUser();
    }
    ```
### Comments
  * The program is coded in English with proper spelling, grammar and formatting.
  * Comments should be full sentences, and directly above the target code. Make sure to comment where it's needed.
  * Comments should help explain the code, and not over complicate it. Make sure to re-write bad code instead of trying to explain it.
  * Multiline comments should look like the example below:
    ```csharp
    /*
    This is a comment
    consisting of
    multiple lines.
    */
    ```

### Indenting
  * Functions, loops and statements should have the opening curly bracket starting below the expression following the example below:
    ```csharp
    int functionName ()
    {
        // Code here..
    }
    ```
   * Use whitespace when differenating between datatypes, functions, and other function calls following the example below:
     ```csharp 
     int functionName() {
        int age;
        int score;
        string name;
        
        while(score < 20) 
        {
            // Do something..
        }
        
        functionName3.run();
     }
     ```
    * Use a single tab when separating code levels to make the code easy to read following the example below:
      ```csharp
      int functionName() 
      {
        if (condition1) 
        {
            if (condition2) 
            {
                if (condition3) 
                {
                    // Do something..
                } else 
                {
                    // Do something else..
                }
            }
        }
      }
      ```