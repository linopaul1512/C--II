import requests
import random
import infomascotas as m
import json

def generar(qty):
    dueños = []

    for i in range(0, qty):
        mascotas = []
        cantidadMascotas = random.randint(1, 7)

        for i in range(0, cantidadMascotas):
            mascotas.append({
                'Nombre': m.NombreAleatorio(),
                'Especie': m.TipoAleatorio(),
                'Peso': round(random.random() * 20, 2),
                'FechaNacimiento': m.FechaAleatoria()
            })

        person = requests.get('https://randomuser.me/api/').json()['results'][0]
        dueños.append({
            'Cedula': f'{random.randint(1,31000000)}',
            'Nombre': f'{person["name"]["first"]} {person["name"]["last"]}',
            'FechaNacimiento': person["dob"]["date"],
            'Direccion': f'{person["location"]["street"]["name"]} - {person["location"]["city"]}, {person["location"]["state"]}. {person["location"]["country"]}',
            'CantidadMaximaMascotas': random.randint(5,10),
            'Telefono': person["cell"],
            'Mascotas': mascotas
        })

    return dueños

def guardar(filename, dueños):
    dueños_json = json.dumps(dueños)

    with open(filename, 'w') as outfile:
        outfile.write(dueños_json)

if __name__ == "__main__":
    try:
        dueños = generar(350)
        guardar('data.json', dueños)
    except Exception as e:
        print(e)