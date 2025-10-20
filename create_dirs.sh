#!/bin/bash

# Comprueba si se han proporcionado el número correcto de argumentos.
if [ "$#" -ne 2 ]; then
    echo "Uso: $0 <número_de_directorios> <nombre_base>"
    exit 1
fi

# Asigna los argumentos a variables para mayor claridad.
NUM_DIRS=$1
BASE_NAME=$2

# Bucle que se ejecuta desde 1 hasta el número de directorios especificado.
for i in $(seq 1 $NUM_DIRS)
do
    # Construye el nombre del directorio y lo crea.
    mkdir "${BASE_NAME}_${i}"
    echo "Directorio creado: ${BASE_NAME}_${i}"
done

echo "¡Proceso completado!"