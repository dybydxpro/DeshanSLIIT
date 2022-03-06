// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Material Select Initialization

//$(document).ready(function () {
//    $.ajax({
//        url: 'https://localhost:7032/api/All/getCatData',
//            type: 'GET',
//            dataType: 'json',
//            success: function (data, textStatus, xhr) {
//        console.log(data);
//    },
//        error: function (xhr, textStatus, errorThrown) {
//            console.log('Error in Database');
//        }  
//    });  
//});

function getData() {
    $.ajax({
        dataType: 'json',
        url: 'https://localhost:7032/api/All/getCatData',
        data: { data: data }
    }).done(function (data) {
        manageRow(data.data);
    });
}

function manageRow(data) {
    var rows = '';
    $.each(data, function (key, value) {
        rows = rows + '<option value="' + value.categoryType +'"/>';
    });
    $("browsers").html(rows);
}