<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Book extends Model
{
    //
    protected $table = 'book';
    protected $fillable = ['id','book_name','isbn_no','book_price'];
}
