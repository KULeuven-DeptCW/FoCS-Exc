#!/bin/bash
git clone "https://github.com/KULeuven-DeptCW/FoCS-Exc" "tmp"
cd "tmp"
ls
for (( i=1;$i<=$#;i=$i+1 ))
do
	make "Fundamentals_of_Computer_Science/${!i}.pdf"
done
cd ..
rm -rf "tmp"
