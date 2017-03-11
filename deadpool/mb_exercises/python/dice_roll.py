#!/usr/bin/env python
# -*- coding: utf-8 -*-

"""dice_roll.py: Roll a dice."""

import random
min = 1
max = 12

roll_again = "yes"

while roll_again == "yes" or roll_again == "y":
    print "Rolling the die..."
    print "The value is...."
    for x in range (0,3):
        print random.randint(min, max)
    roll_again = raw_input("Do you want to roll the die again?")

print "\nThanks for playing!"
