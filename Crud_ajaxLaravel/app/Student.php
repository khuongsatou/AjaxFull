<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Student extends Model
{
    //
	protected $table = 'student';
	protected $fillable = ['id','ho_ten','ngay_sinh','gioi_tinh','sdt','dia_chi'];
}
