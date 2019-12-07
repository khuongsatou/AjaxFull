<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class NguoiDungController extends Controller
{
    public function dangNhap(Request $request){
        $tenDangNhap = $request->ten_dang_nhap;
        $matKhau = $request->mat_khau;
        if($tenDangNhap == 'tttuan' && $matKhau == '123'){
            return response()->json([
                'success' => true,
                'message' => 'Dang nhap thanh cong',
                'token' => 'day_la_token'
            ]);
        }
        return respose()->json([
            'success',
        ]);
    }

    public function layThongTin(Request $request){
        $token = $request->header   
    }
    {
        # code...
    }
}
