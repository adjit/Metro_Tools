Select
	'Metsales' as 'Distributor',
	th.CSTPONBR as 'PO',
	tr.SOPNUMBE,
	tr.QUANTITY as 'Qty',
	tr.ITEMNMBR,
	tr.ITEMDESC,
	tr.UNITPRCE,
	tr.XTNDPRCE,
	st.CMMTTEXT
From
	Metro.dbo.SOP30200 th,
	Metro.dbo.SOP30300 tr

	Left Join Metro.dbo.SOP10202 st
	on	tr.SOPNUMBE = st.SOPNUMBE AND
		tr.LNITMSEQ = st.LNITMSEQ

Where
	th.CUSTNMBR = '{0}' AND
	th.DOCDATE between '{1}' and '{2}' AND
	th.SOPTYPE = 3 AND
	tr.SOPNUMBE = th.SOPNUMBE AND 
	tr.XTNDPRCE > 0

Order by SOPNUMBE