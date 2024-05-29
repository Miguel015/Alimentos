// Inicializar isotope
var $grid = $('.mel-grid').isotope({
    itemSelector: '.mel-grid-item',
    columnWidth: '.mel-grid-sizer',
    percentPosition: true,
    getSortData: {
        price: '[data-price] parseInt'
    }
});

// Filtrado al hacer click en botones
$('.mel-filter-nav').on('click', '.mel-filter', function () {
    var filterValue = $(this).attr('data-filter');
    $grid.isotope({
        filter: filterValue
    });
});

// Cambiar clase is-checked en botones de filtros
$('.mel-filter-nav').each(function (i, buttonGroup) {
    var $buttonGroup = $(buttonGroup);
    $buttonGroup.on('click', '.mel-filter', function () {
        $buttonGroup.find('.is-checked').removeClass('is-checked');
        $(this).addClass('is-checked');
    });
});

// Funciones para ordenar por precio ascendente y descendente y manejar .is-checked
$('#priceSortAsc, #priceSortDesc').on('click', function () {
    var sortByValue = $(this).attr('data-sort-by');
    var sortDirection = $(this).attr('data-sort-direction') === 'asc' ? true : false; // true para ascendente, false para descendente

    // Remueve la clase .is-checked de ambos botones de ordenar por precio
    $('#priceSortAsc, #priceSortDesc').removeClass('is-checked');
    // Agrega la clase .is-checked al botón que fue seleccionado
    $(this).addClass('is-checked');

    $grid.isotope({
        sortBy: sortByValue,
        sortAscending: sortDirection
    });
});
