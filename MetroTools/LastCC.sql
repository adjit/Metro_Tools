Select 
	cc.SOPNUMBE,
	cc.CARDNAME,
	cc.RCTNCCRD
FROM Metro.dbo.SOP10103 cc
Join (
	select * from Metro.dbo.SOP30200 h
	join (
		Select
			MAX(DOCDATE) Last_Sale
		From Metro.dbo.SOP30200
		Where CUSTNMBR = '{0}' and SOPTYPE = 3
	) MD
		on MD.Last_Sale = h.DOCDATE
		Where h.CUSTNMBR = '{1}'
) LS

ON LS.SOPNUMBE = cc.SOPNUMBE