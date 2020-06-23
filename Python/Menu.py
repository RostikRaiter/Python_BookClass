import os
import BookClass
from BookClass import bookList
from BookClass import Book

def menu():
    print("Type 1 if you want to sort by author")
    print("Type 2 if you want to sort by name of book")
    print("Type 3 if you want to sort by amount of pages")
    print("Type 4 if you want to search by author")
    task = int(input('Enter the number:'))
    if task != 1 and task !=2 and task != 3 and task !=4 and task !=5:
        print("Error, try again")
        menu()
    if task == 1:
        bookList.sort( key = lambda member: getattr(member,'author').lower(), reverse = False )
        for book in bookList:
            print("\"%s\"  %s (%s) (%s) (%s) " % (book.author, book.name, book.pages, book.date, book.copiessold))

    if task == 2:
        bookList.sort( key = lambda member: getattr(member,'name').lower(), reverse = False )
        print("... then show all info :")
        for book in bookList:
            print("\"%s\"  %s (%s) (%s) (%s)" % (book.author, book.name, book.pages, book.date, book.copiessold))
    if task == 3:
        bookList.sort( key = lambda member: getattr(member,'pages').lower(), reverse = False )
        for book in bookList:
            print("\"%s\"  %s (%s) (%s) (%s)" % (book.author, book.name, book.pages, book.date, book.copiessold))

    if task == 4:
        print("What book did author write?")
        look =input()
        for book in bookList:
            if look in book.author:
                print("%s: \"%s\"" % (book.name, book.pages))
    if task == 5:
        print("Enter new Book:")
        for book in bookList:
            book.author = input("Enter Author's name:\n")
            book.name = input("Enter name of the book:\n")
            book.pages = int(input("Enter amount of pages:\n"))
            book.date = int(input("Enter date of book:\n"))
            book.copiessold = int(input("Enter amount of sold copies:\n"))
            with open('text.txt', 'a') as f:
                for book in bookList:
                    f.write("%s" % book)
menu()