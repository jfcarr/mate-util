# MATE Utility

MATE Utility (mate-util) is a CLI application allowing quick and easy manipulation of internal application settings for the MATE desktop environment.  It will be extended in the future, but for now it only supports enabling and disabling of a touchpad.

Tested in Ubuntu MATE.

## Usage

```bash
mate-util <command> <subcommand>
```

### Examples

Enable the touchpad:

```bash
mate-util touchpad enable
```

Disable the touchpad:

```bash
mate-util touchpad disable
```

Show current touchpad enabled state:

```bash
mate-util touchpad check
```
