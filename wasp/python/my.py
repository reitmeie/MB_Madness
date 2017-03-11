#!/usr/bin/env python
# -*- coding: utf-8 -*-

"""my.py: draw cards"""

import random
rank = [1,2,3,4,5,6,7,8,9,10,"jack","queen", "king", "Ace"]
suit=  ["dod", "cat" "animals"]
maxrank=len(rank)-1
maxsuit= len(suit)-1
roll_again = "yes"
while roll_again == "yes" or roll_again == "y":
    print "Rolling the dice..."
    print "The values are...."
    print rank[random.randint(0, maxrank)],
    print suit[random.randint(0, maxsuit)]
    roll_again= raw_input("draw a card?")
    

    
    
    
