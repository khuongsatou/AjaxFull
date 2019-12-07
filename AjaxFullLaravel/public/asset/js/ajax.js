$(document).ready(function () {
	$(".update").click(function (){
		var rowId = $(this).attr('id');
		var qty = $(this).parent().parent().find("input").val();
		var token = $("input[name='_token']").val();
		//alert(token);
		$.ajax({
			url:'cap-gio-hang/'+rowId+'/'+qty,
			type:'GET',
			cache:false,
			data:{"_token":token,"id":rowId,"qty":qty},
			success:function(data) {
				if(data == "success"){
					//alert('Yes');
					window.location = "gio-hang"
				}
			}
		});
	});
});

