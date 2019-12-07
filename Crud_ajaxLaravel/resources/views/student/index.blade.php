
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Document</title>
	<!-- Latest compiled and minified CSS & JS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
	<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.1.4/toastr.min.css">

	<meta name="csrf-token" content="{{ csrf_token() }}">​
</head>
<body>
	<div class="container">
		<a href="#" class="btn btn-success btn-add" data-target="#modal-add" data-toggle="modal">Add</a>
		<div class="table-responsive">
			<table class="table table-hover">
				<thead>
					<tr>
						<th>#</th>
						<th>Họ tên</th>
						<th>Giới tính</th>
						<th>Ngày sinh</th>
						<th>Số điện thoại</th>
						<th>Địa chỉ</th>
						<th>Action</th>
					</tr>
				</thead>
				<tbody>
					{{-- biến $todos được controller trả cho view
						chứa dữ liệu tất cả các bản ghi trong bảng students. Dùng foreach để hiển
						thị từng bản ghi ra table này. --}}

						@foreach ($students as $student)
						<tr>
							<td id="{{$student->id}}">{{$student->id}}</td>
							<td id="hoten-{{$student->id}}">{{$student->ho_ten}}</td>
							<td id="gioitinh-{{$student->id}}">{{$student->gioi_tinh}}</td>
							<td id="ngaysinh-{{$student->id}}">{{$student->ngay_sinh}}</td>
							<td id="sdt-{{$student->id}}">{{$student->sdt}}</td>
							<td id="diachi-{{$student->id}}">{{$student->dia_chi}}</td>
							<td>
								<button data-url="{{route('show',['id'=>$student->id])}}" type="button" data-target="#show" data-toggle="modal" class="btn btn-info btn-show">Detail</button>
								<button data-url="{{route('edit',['id'=>$student->id])}}"​ type="button" data-target="#edit" data-toggle="modal" class="btn btn-warning btn-edit">Edit</button>
								<button data-url="{{route('delete',['id'=>$student->id])}}"​ type="button" data-target="#delete" data-toggle="modal" class="btn btn-danger btn-delete">Delete</button>
							</td>
						</tr>
						@endforeach
					</tbody>
				</table>
			</div>
			{{-- {{$students->links()}} --}}
		</div>

		@include('student.add')
		@include('student.detail')
		@include('student.edit')

		<script
		src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"
		></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
		<script src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js" type="text/javascript" charset="utf-8" async defer></script>
		<script type="text/javascript" charset="utf-8">
			$.ajaxSetup({
				headers: {
					'X-CSRF-TOKEN': $('meta[name="csrf-token"]').attr('content')
				}
			});
		</script>
		<script type="text/javascript">
			$(document).ready(function () {
				$('#form-add').submit(function(e){
					var ten = $('#hoten-add').val();
					var gioitinh =$('#gioitinh-add').val();
					var ngaysinh =$('#ngaysinh-add').val()
					var sdt =$('#sdt-add').val();
					var diachi =$('#diachi-add').val();
					var url = $(this).attr('data-url');
					//alert(url);
					e.preventDefault();
					$.ajax({
						type: 'post',
						url: url,
						data: {
							"hoten":ten,
							"gioitinh":gioitinh,
							"ngaysinh":ngaysinh,
							"sdt":sdt,
							"diachi":diachi,
						},
						success: function(data) {
							if(data=="success"){
								alert("Them thanh cong");
								window.location = "Crudajax"
							}
						},
						error: function (jqXHR, textStatus, errorThrown) {
							//xử lý lỗi tại đây
						}
					});
				});

				$('.btn-show').click(function(){
					var url = $(this).attr('data-url');
					var id = $(this).attr('id');
					//alert(id);
					$.ajax({
						type: 'get',
						url: url,
						success: function(response) {
							console.log(response);
							$('h1#id').text(response.data.id);
							$('h1#hoten').text(response.data.ho_ten);
							$('h1#gioitinh').text(response.data.gioi_tinh);
							$('h1#ngaysinh').text(response.data.ngay_sinh);
							$('h1#sdt').text(response.data.sdt);
							$('h1#diachi').text(response.data.dia_chi);
						},
						error: function (jqXHR, textStatus, errorThrown) {
							//xử lý lỗi tại đây
						}
					});
				});

				$('.btn-delete').click(function(){
					var url = $(this).attr('data-url');
					//alert(url);
					var _this = $(this);
					if (confirm('Bạn có muốn xóa sinh viên này?')) {
						$.ajax({
							type: 'get',
							url: url,
							success: function(data) {
								if(data=="true"){
									window.location = "Crudajax"
								}
							},
							error: function (jqXHR, textStatus, errorThrown) {
								//xử lý lỗi tại đây
							}
						});
					}
				});

				$('.btn-edit').click(function(e){

					var url = $(this).attr('data-url');
					//alert(url);
					$('#modal-edit').modal('show');

					e.preventDefault();

					$.ajax({
							//phương thức get
							type: 'get',
							url: url,
							success: function (response) {
								//đưa dữ liệu controller gửi về điền vào input trong form edit.
								$('#hoten-edit').val(response.data.ho_ten);
								$('#ngaysinh-edit').val(response.data.ngay_sinh);
								$('#gioitinh-edit').val(response.data.gioi_tinh);
								$('#sdt-edit').val(response.data.sdt);
								$('#diachi-edit').val(response.data.dia_chi);
								//thêm data-url chứa route sửa todo đã được chỉ định vào form sửa.
								$('#form-edit').attr("data-url","Crudajax/update/"+response.data.id);
							},
							error: function (error) {
								
							}
					});
				});

				$('#form-edit').submit(function(e){
					e.preventDefault();
					var url=$(this).attr('data-url');
					//alert(url);
					$.ajax({
						type: 'put',
						url: url,
						data: {
							"hoten": $('#hoten-edit').val(),
							"gioitinh": $('#gioitinh-edit').val(),
							"ngaysinh": $('#ngaysinh-edit').val(),
							"sdt": $('#sdt-edit').val(),
							"diachi": $('#diachi-edit').val(),
						},
						success: function(data) {
							// console.log(response.studentid)
							if(data=="true")
							{
								alert("Sua thanh cong");
								window.location = "Crudajax"
							}
						},
						error: function (jqXHR, textStatus, errorThrown) {
							//xử lý lỗi tại đây
						}
					});
				});
			});
		</script>
	</body>
	</html>​