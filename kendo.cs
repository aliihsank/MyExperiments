 // Set validation rule for a spesific type of date format in cells :
 
 itemCell.push({ value: val[column], textAlign: 'left' , format: '@', wrap: true, 
                  validation: {
                        dataType: 'custom',
                        from: 'AND(NOT(ISERROR(FIND(\"/\", R[0]C[0]))), NOT(ISERROR(FIND(\"/\", R[0]C[0]))), ISERROR(FIND(\" \", R[0]C[0])), LEN(R[0]C[0])==10)',
                        showButton: true,
                        allowNulls: true,
                        type: 'reject',
                        titleTemplate: ' Tarih Formatı Hatalı',
                        messageTemplate: 'Girdiğiniz tarih hatalı!'
                  } 
  });
