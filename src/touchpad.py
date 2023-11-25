#!/usr/bin/env python3

import os
import sys

def help_message():
    print("Specify argument of 'enable' or 'disable' or 'check'")

if __name__ == "__main__":
    schema = "org.mate.peripherals-touchpad"
    key = "touchpad-enabled"

    is_set = False

    if len(sys.argv) == 1:
        help_message()
        sys.exit()

    if sys.argv[1] == "enable":
        os.system(f"gsettings set {schema} {key} true")
        is_set = True

    if sys.argv[1] == "disable":
        os.system(f"gsettings set {schema} {key} false")
        is_set = True

    if sys.argv[1] == "check":
        os.system(f"gsettings get {schema} {key}")
        is_set = True

    if is_set == False:
        help_message()
