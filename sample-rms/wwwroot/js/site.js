$(function (e) {
   
    var spinner = '<div class="spinner-border" role="status"><span class="sr-only" > Loading...</span ></div >';
    $(document).ready(function (e) {
        //var date = new Date(Date.parse(myCSharpString));
        //const d = new Date('2010-08-05');
        //const ye = new Intl.DateTimeFormat('en', { year: 'numeric' }).format(d);
        //const mo = new Intl.DateTimeFormat('en', { month: 'short' }).format(d);
        //const da = new Intl.DateTimeFormat('en', { day: '2-digit' }).format(d);
        //document.getElementById('configform').reset();
        $('input[name="datetimes"]').daterangepicker({
            timePicker: true,
            //startDate: moment().startOf('hour'),
            //endDate: moment().startOf('hour').add(32, 'hour'),
            timePicker24Hour:true,
            autoUpdateInput: false,
            locale: {
                cancelLabel: 'Clear'
            }
        });
        $('input[name="datetimes"]').on('apply.daterangepicker', function (ev, picker) {
            $(this).val(picker.startDate.format('MM/DD/YYYY HH:mm') + ' - ' + picker.endDate.format('MM/DD/YYYY HH:mm')).change();
        });
        $('input[name="datetimes"]').on('cancel.daterangepicker', function (ev, picker) {
            $(this).val('').change();
        });

        getReservationListTable(0, '');

    });
    const getReservationListTable = (seat, daterange) => {
        $('.table_container').html(spinner);
        $.get('/Home/DisplayReservations?seating=' + seat + '&daterange=' + daterange, function (result) {
            $('.table_container').html(result);
        });
    };
   
    $(document).on('click', '#btn_new_reservation', function (e) {
        $('#modalReserveTable').modal('show');
        $.get('/Home/Reservation', function (result) {
            $('#modalReserveTable .modal-body').html(result);
            $("#frm_new_reservation").validate({
                rules: {
                    TableId: {
                        required: true
                    },
                    Time: {
                        required: true
                    }
                }
            });
        });
    });
    $(document).on('click', '#btn_submit_reservation', function (e) {
       
        if ($('#frm_new_reservation').valid()) {
            $('#modalReserveTable').modal('hide');
            $.post('/Home/Reservation', $('#frm_new_reservation').serialize(), function (response) {
                if (response.Result) {
                    swal('Success', 'Successfully Reserved', 'success');
                    getReservationListTable($("#ddl_filter_seat").val(), $('#input_filter_time').val());
                }
            });
        }
        
    });
    $(document).on('change', '#ddl_filter_seat', function (e) {
        getReservationListTable($("#ddl_filter_seat").val(), $('#input_filter_time').val());
    });
    $(document).on('change', '#input_filter_time', function (e) {
        getReservationListTable($("#ddl_filter_seat").val(), $('#input_filter_time').val());
    });

});


