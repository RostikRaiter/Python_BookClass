import sys
import os
import Menu
class Book(object):
    def __init__(self, author=None, name=None, pages=1 , date = 1564, copiessold = 0):
        if pages <=1:
            print("Error, pages can't be less than 1")
            sys.exit()

        if author.isdigit():
            print("Error, author can't have numbers")
            sys.exit()
        if not author.isalpha():
            print("Error, author must only have letters")
            sys.exit()
        if name.isdigit():
            print("Error, name can't have numbers")
            sys.exit()
        if not name.isalpha():
            print("Error, name must only have letters")
            sys.exit()
        if date <=1564:
            print("Error, date can't be less than 1564")
            sys.exit()
        if copiessold <=0:
            print("Error, copiessold can't be less than 0")
            sys.exit()
        self.author = author
        self.name = name
        self.pages = pages
        self.date= date
        self.copiessold = copiessold



def read_file(file_name):
    result = []
    with open(file_name, 'r') as f:
        for line in f:
            sc = 0
            sub_result = []
            for word in line.split():
                sub_result.append(word)
            result.append(Book(sub_result[0], sub_result[1], int(sub_result[2]),int(sub_result[3]),int(sub_result[4])))
    return result

fname = input('Enter file name')
if not os.path.isfile(fname):
    print("Error, file does not exist.")
    exit()

bookList = read_file(fname)




