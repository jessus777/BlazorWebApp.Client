window.InputPhoneMask = () => {
    $('.telphone').mask("(999) 999-9999").focusout(function(event) {
        var target, phone, element;
        target = (event.currentTarget) ? event.currentTarget : event.srcElement;
        phone = target.value.replace(/\D/g, '');
        element = $(target);
        element.unmask();
        if (phone.length === 10) {
            console.log(phone);
            element.mask("(999) 999-9999");
        }
        else {
            console.log("debe ser completo");
        } 
    });

};

window.DateSelect = () => {
    $('#selectDate').datepicker({
        format: "dd/mm/yyyy",
        autoclose: true,
        todayHighlight: true,
        language:"es"
    }).on('changeDate', function(e) {
        console.log(e.format(0, "dd/mm/yyyy"));
        $('#floatingDate').val(e.format(0, "dd/mm/yyyy"));
    });

};

window.Select2demo = () => {
    $('#floatingSelectState').select2({
        theme: "bootstrap-5",
        width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
        placeholder: $(this).data('placeholder'),
    });

};







$.fn.datepicker.dates['es'] = {
    days: ["Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"],
    daysShort: ["Dom", "Lun", "Mar", "Mie", "Jue", "Vie", "Sáb"],
    daysMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa"],
    months: ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"],
    monthsShort: ["Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"],
    today: "Hoy",
    clear: "Borrar",
    format: "dd/mm/yyyy",
    titleFormat: "MM yyyy", /* Leverages same syntax as 'format' */
    weekStart: 0
};


