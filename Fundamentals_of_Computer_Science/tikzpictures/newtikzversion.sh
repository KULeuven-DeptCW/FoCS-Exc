for f in *.tex
do
	sed -i -e 's/,on grid//' "$f"
done
