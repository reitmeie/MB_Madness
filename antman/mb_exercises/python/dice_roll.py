#!/usr/bin/env python
# -*- coding: utf-8 -*-

"""dice_roll.py: Pick a Card."""

import random
min = 1
max = 4

roll_again = "yes"

while roll_again == "yes" or roll_again == "y":
    print "Drawing a Card..."
    print "The values are...."
    print random.randint(min, max)
    print random.randint(min, max)

    roll_again = raw_input("Would you like to draw a card again?")

print "\nThanks for playing!"
