Select * from Metro.dbo.SOP10103 cc
Join (
	select * from Metro.dbo.SOP30200 h
	join (
		Select
			MAX(DOCDATE) Last_Sale
		From Metro.dbo.SOP30200
		Where CUSTNMBR = '01001AD' and SOPTYPE = 3
	) MD
		on MD.Last_Sale = h.DOCDATE
		Where h.CUSTNMBR = '01001AD'
) LS

ON LS.SOPNUMBE = cc.SOPNUMBE