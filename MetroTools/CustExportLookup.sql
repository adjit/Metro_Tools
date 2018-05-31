Select
	'Metsales' as 'Distributor',
	th.CSTPONBR as 'PO',
	tr.SOPNUMBE as 'Invoice Number',
	tr.QUANTITY as 'Qty',
	tr.ITEMNMBR as 'Product Number',
	tr.ITEMDESC as 'Product Description',
	tr.UNITPRCE as 'Unit Price',
	tr.XTNDPRCE as 'Extended Price',
	tx.Tracking_Number,
	shv.[Delivery Description],
	isnull(st.CMMTTEXT, 'No Serial Number') as 'Serial Numbers'
From
	Metro.dbo.SOP30200 th,
	Metro.dbo.SOP10107 tx,
	StarShip.dbo.ShipmentHeaderView shv,
	Metro.dbo.SOP30300 tr

	Left Join Metro.dbo.SOP10202 st
	on	tr.SOPNUMBE = st.SOPNUMBE AND
		tr.LNITMSEQ = st.LNITMSEQ

Where
	th.CUSTNMBR = '{0}' AND
	th.DOCDATE between '{1}' and '{2}' AND
	th.SOPTYPE = 3 AND
	tr.SOPNUMBE = th.SOPNUMBE AND
	tr.XTNDPRCE > 0 AND
	tx.SOPNUMBE = tr.SOPNUMBE AND
	tx.Tracking_Number = shv.[Master Tracking Number]

Order By [Invoice Number]