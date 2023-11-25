#!/usr/bin/env bash

sudo apt update
sudo apt upgrade

sudo snap refresh

check-reboot # requires the check-reboot.sh script to be in the path, without the extension

read -p "Press [ENTER] to exit " </dev/tty
