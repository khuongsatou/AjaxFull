<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

//Nguyễn Việt Hân
//0306171339

// Route::get('/',function(){
// 	$book = App\Book::all();
// 	return view('list_book',compact('book'));
// })->name('home');
// Route::group(['prefix'=>'book'],function(){
// 	Route::get('them-moi','BookController@create')->name('them_moi');
// 	Route::post('them-moi','BookController@them_moi')->name('add_book');
// 	Route::get('sua-sach/{id}','BookController@edit')->name('re_update');
// 	Route::post('sua-sach/{id}','BookController@update')->name('update');
// 	Route::get('xoa-sach/{id}','BookController@destroy')->name('delete');
// });

Route::resource('/Crudajax','StudentController');
Route::post('/Crudajax','StudentController@store')->name('add');
Route::get('/Crudajax/{id}','StudentController@show')->name('show');
Route::get('/Crudajax/edit/{id}','StudentController@edit')->name('edit');
Route::put('/Crudajax/update/{id}','StudentController@update');
Route::get('/Crudajax/delete/{id}','StudentController@destroy')->name('delete');