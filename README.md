# HomeworldRM-HOD_Fixer

When using RODOH to convert old HODs to DAE files, some models will be broken. [See details about this bug here](https://forums.gearboxsoftware.com/t/rodoh-has-cometh/291320/126).
This tool can batch convert those broken HODs from "Triangle Strip" format to "Triangle List" format, so that they won't be broken after converted to DAEs.

In fact, this tool is a modified version of [CFHodEd](https://github.com/Fallen-Angel/CFHodEd). I've modified the code to let it convert the format when open a HOD, and add a wrapper for batch processing.

##Usage:
Drag and drop the folder containing .hod files such as 'ship' and 'subsystem' to HOD_Fixer.exe.
