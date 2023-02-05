# Openiddict Samples using mongodb

I used original sample from [openiddict/openiddict-core](https://github.com/openiddict/openiddict-core) and some ideas taken from [Myrmex/oid-credentials-mongo](https://github.com/Myrmex/oid-credentials-mongo)

## Run

- install npm
- install dotnet sdk
- install docker
- run mongo image ```docker run -d --name mongodb -p 27017:27017 mongo```
- build and run ```./OpeniddictSamples.sln```

## Throubles

- Correlation failed.
  - enabling SSL/TLS
  - or use firefox
  - or navigate to `chrome://flags/` and change `Cookies without SameSite must be secure` to `Disabled`
