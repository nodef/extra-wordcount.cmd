Count words in a file, and list them in descending order in Windows Console.
> 1. Download [exe file](https://github.com/cmdf/extra-wordcount/releases/download/1.0.0/ewordcount.exe).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
ewordcount [-p <regex pattern>] <source file>
:: -p : specify regex pattern for items/words to be counted
::      (e.g. -p gl\w+, to look for gl calls in adb logs)
```

```batch
:: Get all words count
ewordcount ideas.txt
: (word counts are displayed)

:: Get all words count to file
ewordcount project.txt > project-count.log
: (word counts stored in "project-count.log")

:: Get Specific words count
ewordcount -p gl\w+ adb.log > adb-count.log
: (counts of word starting with "gl" is only stored)
```


[![cmdf](https://i.imgur.com/ApzHpHZ.jpg)](https://cmdf.github.io)
