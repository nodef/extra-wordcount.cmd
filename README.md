# wordcount

Use this program to **count words** in a *file*, and *list* them in **descending** *order*.


## usage

- Download [word-count](#).
- Drop it in your *directory*.
- If you want it to be usable from **anywhere**, add its path to the `PATH` *environment variable*.
- Start a *command prompt* in the **same** *directory*.
- Follow the [examples](#examples) or the [reference](#reference).


## examples

* Get all words count
```batch
word-count ideas.txt
: (word counts are displayed)
```

* Get all words count to file
```batch
word-count project.txt > project-count.log
: (word counts stored in "project-count.log")
```

* Get Specific words count
```batch
word-count -p gl\w+ adb.log > adb-count.log
: (counts of word starting with "gl" is only stored)
```


## reference

```
word-count [-p <regex pattern>] <source file>
-p : specify regex pattern for items/words to be counted
     (e.g. -p gl\w+, to look for gl calls in adb logs)
```


## objective

The objective of this project is to provide a mechanism to know
the most used function in a library for a use case, so as to be
able to find the best places to start optimizing.


## thanks

[Stack Overflow](http://stackoverflow.com) for a lot of QAs <br>
[Microsoft MSDN](https://msdn.microsoft.com) for the huge support in every direction <br>
