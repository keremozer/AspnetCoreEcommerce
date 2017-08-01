var url = location.pathname;
 
$(function () {

    $.each($('.list-group a'), function (i, obj) {
         
        if (url == $(obj).attr('href')) {

            $(this).addClass("active");
        }
    });
    $(".add2cart").on("click", function () {
        var id = $(this).data("id");
        $.addToCart(id);
    
    });
    $(".remove2cart").on("click", function () {
        var id = $(this).data("id");
        $.removeToCart(id);
       
    });
    $(".remove2adress").on("click", function () {
        var id = $(this).data("id");
        $.removeAdress(id);

    });
    function removeProduct() {
        $('#Sepetim > tbody').on("click", ".remove2cart", function () {
            $(this).parents('tr').hide(5000).detach();
        });
    }
    $(".update2cart").on("click", function () {
        var id = $(this).data("id");
        var quantity = $(this).prev().val();
        $.updateToCart(id, quantity);
       
    })
    $(".num").keypress(function (e) {
        var regex = new RegExp("^[0-9]");
        var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
        if (regex.test(str)) {
            return true;
        }
        e.preventDefault();
        return false;
    });
    $("#Country").on("change", function () {
        
        var id = $(this).val();
        $.getCity(id);
    });
    $("#Adresim > tbody ").find('tr input[type=radio]').eq(0).prop('checked', true)
    $("#Complete").on("click", function () {
        var id = $("#Adresim > tbody ").find('tr input[type=radio]:checked').data("id");
        if (id == null) {
            alert("Lütfen bir adres seçiniz!")
        } else {
            $.complete(id);
        }
       
    });
    $.extend({
        addToCart: function (id) {
            $.ajax({
                type:"post",
                url:"/ShoppingCart/AddToCart",
                data: { "id":id },
                success: function (result) {
                    if (result.ok) {
                        alert("Ürün sepetinize eklenmiştir.");
                        $("#SepetCount").text(result.count);
                       
                    }else {
                        alert("Ürün sepetinize eklenememiştir.");
                    }
                }
            })
        },
        removeToCart: function (id) {
            $.ajax({
                type: "post",
                url: "/ShoppingCart/RemoveToCart",
                data: { "id": id },
                success: function (result) {
                    if (result.ok) {
                        alert("Ürün sepetinizden çıkarılmıştır.");
                        $("#SepetCount").text(result.count);
                        location.reload();
                    } else {
                        alert("Ürün sepetinizden çıkarılamamıştır.");
                    }
                }
            })
        },
        updateToCart: function (id, quantity) {
            $.ajax({
                type: "post",
                url: "/ShoppingCart/UpdateToCart",
                data: { "id": id ,"quantity":quantity},
                success: function (result) {
                    if (result.ok) {
                        alert("Sepetiniz güncellenmiştir.");
                        $("#SepetCount").text(result.count);
                        location.reload();
                    } else {
                        alert("Sepetiniz güncellenememiştir.");
                    }
                }
            })
        },
        getCity: function (id) {
            $.ajax({
                type: "post",
                url: "/Account/GetCity",
                data: { "id": id },
                success: function (result) {
                    $("#City option").remove();
                    var dflt = '<option value>--Seçiniz--</option>';
                    $("#City").append(dflt);
                    if (result.ok) {
                        $.each(result.list, function (index, item) {
                             var optionhtml = '<option value="' + item.value + '">' + item.text + '</option>';
                            $("#City").append(optionhtml);
                        });
                    } else {
                        alert("Şehir getirelemedi!");
                    }
                }
            })
        },
        removeAdress: function (id) {
            $.ajax({
                type: "post",
                url: "/Account/RemoveAdress",
                data: { "id": id },
                success: function (result) {
                    if (result.ok) {
                        alert("Adresiniz başarıyla silinmiştir.");
                        location.reload();
                    } else {
                        alert("Adresiniz başarıyla silinememiştir.");
                    }
                }
            })
        },
        complete: function (id) {
            $.ajax({
                type: "post",
                url: "/ShoppingCart/Complete",
                data: { "id": id },
                success: function (result) {
                    if (result.ok) {
                        alert("Siparisiniz tamamlanmıştır.");
                        setTimeout(function () {
                            window.location.href = window.location.origin + result.go;
                        });
                       
                    } else {
                        alert("Şiparisiniz tamamlanamadı.");
                    }
                }
            })
        }
    })
});