rule pdf1 {
    meta:
        description = "Valida si el archivo es un PDF .jpg"
    condition:
        uint16(0) == 0x46445025
}
