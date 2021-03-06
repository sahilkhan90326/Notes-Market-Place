//Pagination for notes//
$(document).ready(function(){
    $('#published_data').after('<div class="row"><div class="col-md-12"><div class="pagination p1"><ul id="nav2"><a><li><img src="images/dashboard/left-arrow.png"></li></a></ul></div></div></div>');
    var rowsShown = 4;
    var rowsTotal = $('#published_data tbody tr').length;
    var numPages = rowsTotal/rowsShown;
    for(i = 0;i < numPages;i++) {
        var pageNum = i + 1;
        $('#nav2').append('<a href="#" rel="'+i+'"><li>'+pageNum+'</li></a>');
    }
    $('#nav2').append('<a><li><img src="images/dashboard/right-arrow.png"></li></a>');
    $('#published_data tbody tr').hide();
    $('#published_data tbody tr').slice(0, rowsShown).show();
    $('#nav2 a:nth-child(2)').addClass('active');
    $('#nav2 a').bind('click', function(){

        $('#nav2 a').removeClass('active');
        $(this).addClass('active');
        var currPage = $(this).attr('rel');
        var startItem = currPage * rowsShown;
        var endItem = startItem + rowsShown;
        $('#published_data tbody tr').css('opacity','0.0').hide().slice(startItem, endItem).
        css('display','table-row').animate({opacity:1}, 300);
    });
});
