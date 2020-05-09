FoFi - This program is written to remove folders and retain files only. 

If you happened to have many files in nested folders and want to remove all the folders and retain the files, this is the program. The source code is included, feel free to modify it. 

The executable is tested on Win10 in the bin directory, you can download and use directly.  

Source - is the folders with nested folders with files in all of them. 
Destination - is the folder where all the extracted file be placed. 
Start - the operation begins. 



For example, 
Select folder with nested directories. 

 FolderA
 |__> File01.txt
 |__> FolderSubA __> File02.jpg
 |__> FolderSubB __> File03.mp3
 

Output in the destination folder will be as follow:-

 FolderB
 |__>File01.txt
 |__>FolderSubA__File02.jpg
 |__>FolderSubA__File03.mp3
 
 
 If you UNCHECHED Augment folder name on file names, the following is the output. You can decide if you want to overwrite the files in the event of same filename found in different folder. 
 
 FolderB
 |__>File01.txt
 |__>File02.jpg
 |__>File03.mp3


 
