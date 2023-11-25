#!/usr/bin/env bash

FILE=/var/run/reboot-required

if test -f "$FILE"; then
	echo 'A reboot is needed.'
else
	echo 'A reboot is NOT needed.'
fi
