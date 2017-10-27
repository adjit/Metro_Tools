Select 
	LS.DOCDATE,
	cc.SOPNUMBE,
	cc.CARDNAME,
	cc.RCTNCCRD
FROM Metro.dbo.SOP10103 cc
Join (
	select * from Metro.dbo.SOP30200 h
	Where h.CUSTNMBR = '{0}' AND h.SOPTYPE = 3
	AND h.DOCDATE > dateadd(m, -12, getdate() - datepart(d, getdate()) + 1)
) LS

ON LS.SOPNUMBE = cc.SOPNUMBE
ORDER BY LS.DOCDATE DESC