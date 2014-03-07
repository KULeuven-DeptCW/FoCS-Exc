all :
	make "Fundamentals_of_Computer_Science/exercises1.pdf"
%.pdf: %.tex
	bash makepdf.sh $<
%.txt: %.tex
	bash maketext.sh $<
