$(document).ready(function(){
    $('#cart').on("click", function () {
            $('#cart > div').toggle();
            $('#corner').attr("class", "corner-up");
        }
    );
    /*    var newcount = 0;
        
        $('add-tovar').click( function() {
    var allprice = $('#block-cart span#price').attr("price");
            var price = $(this).attr("price");
            var tovarid = $(this).attr("rel");
                             });
                             */
});
