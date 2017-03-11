#!/usr/bin/env python
# -*- coding: utf-8 -*-

"""dice_roll.py: Roll a pair of dice."""

import random
min = 1
max = 10

roll_again = "yes"

while play_again == "play" or play_again == "p":
    print "Rolling the dice..."
    print "The values are...."
    print random.randint(min, max)
    print random.randint(min, max)

    roll_again = raw_input("Would you like to roll the dice again?")

print "\nThanks_for_Playing!"
