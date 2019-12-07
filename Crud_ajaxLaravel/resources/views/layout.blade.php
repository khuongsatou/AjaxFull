<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>De kiem tra - Laravel</title>
	<link href="{{ asset('css/app.css') }}" rel="stylesheet" type="text/css" />
	 <link rel="shortcut icon" href="{{asset('asset/images/favicon.ico')}}">
    <!-- App css -->
    <link href="{{asset('asset/css/bootstrap.min.css')}}" rel="stylesheet" type="text/css" />
    <link href="{{asset('asset/css/icons.min.css')}}" rel="stylesheet" type="text/css" />
    <link href="{{asset('asset/css/app.min.css')}}" rel="stylesheet" type="text/css" />
</head>
<body>
	@yield('content')
	<script src="{{ asset('js/app.js') }}" type="text/js"></script>
	<script src="{{ asset ('assets/js/vendor.min.js')}}"></script>
    <!-- Plugins js-->
    <script src="{{ asset ('assets/libs/twitter-bootstrap-wizard/jquery.bootstrap.wizard.min.js')}}"></script>
    <!-- Init js-->
    <script src="{{ asset ('assets/js/pages/form-wizard.init.js')}}"></script>
    <!-- App js-->
    <script src="{{ asset ('assets/js/app.min.js')}}"></script>
</body>
</html>