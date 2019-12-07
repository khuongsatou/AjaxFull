@extends('layout')
@section('content')
	<div class="wrapper">
            <div class="container-fluid">
                <br>
                <!-- start page title -->
                <div class="row">
                    <div class="col-2">
                        <a href="{{route('them_moi')}}" class="btn btn-primary waves-effect waves-light" name="" value="">Thêm mới</a>
                    </div>
                    <div class="col-8">
                    </div>
                    <div class="col-2">
                    </div>
                    <div class="col-8">
                    </div>
                </div>      
                <!-- end page title --> 
                <br>
                <div class="row">
                    <div class="col-12">
                        <div class="card">
                            <div class="card-body">
                                <table id="basic-datatable" class="table dt-responsive nowrap">
                                    <thead>
                                        <tr>
                                            <th>Id</th>
                                            <th>Tên sách</th>
                                            <th>Số ISBN</th>
                                            <th>Giá</th>
                                            <th>Thao tác</th>                                                    
                                        </tr>
                                    </thead>                              
                                    <tbody>
                                    @foreach($book as $ds)
                                            <tr>
                                                <td>{{$ds->id}}</td>
                                                <td>{{$ds->book_name}}</td>
                                                <td>{{$ds->isbn_no}}</td>
                                                <td>{{$ds->book_price}}</td>
                                                <td>
                                                    <a href="{{route('re_update',['id'=>$ds->id])}}" class="btn btn-warning waves-effect waves-light"><i class="mdi mdi-settings"></i>Sửa</a>
                                                    <a href="{{route('delete',['id'=>$ds->id])}}" class="btn btn-danger waves-effect waves-light"><i class="mdi mdi-close"></i>Xóa</a>
                                                </td>
                                            </tr>
                                    @endforeach
                                    </tbody>
                                </table>
                            </div> <!-- end card body-->
                        </div> <!-- end card -->
                    </div><!-- end col-->
                </div>
                <!-- end row-->     
            </div> <!-- end container -->
		</div>
@endsection