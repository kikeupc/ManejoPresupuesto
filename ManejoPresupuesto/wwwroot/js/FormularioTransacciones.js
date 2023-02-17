function inicializarFormularioTransacciones(urlObtenerCategorias) {
    $("#TipoOperacionId").change(async function () {
        const valorSeleccionado = $(this).val();

        const respuesta = await fetch(urlObtenercategorias, {
            method: 'POST',
            body: valorSeleccionado,
            headers: {
                'content-type': 'application/json'
            }
        });

        const json = await respuesta.json();
        //console.log(json);
        const opciones =
            json.map(categoria => `<option value=${categoria.value}>${categoria.text}</option>`);
        $("#CategoriaId").html(opciones);
    })
}