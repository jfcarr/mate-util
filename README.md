# MATE Utilities

MATE Utilities (mate-util) is a set of operational scripts for the MATE desktop environment.  These have been tested in Ubuntu MATE.

## Scripts

### check-reboot

This Bash script checks for the existence of a `/var/run/reboot-required` file (indicating the need for a reboot) and displays a message accordingly.

Usage:

```bash
check-reboot.py
```

Sample output:

```
A reboot is NOT needed.
```

### touchpad.py

This Python script lets you enable, disable, and check the current status of a touchpad.

Enable the touchpad:

```bash
touchpad.py enable
```

Disable the touchpad:

```bash
touchpad.py disable
```

Check the current state of the touchpad:

```bash
touchpad.py check
```

```
true
```

### upgrade-packages-and-snaps.sh

This Bash script upgrades installed packages, upgrades installed snaps, and displays a message if the system needs to be rebooted afterwards.

Usage:

```bash
upgrade-packages-and-snaps.sh
```
