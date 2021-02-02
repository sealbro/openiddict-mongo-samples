# Openiddict Samples using mongodb

I used original sample from [openiddict/openiddict-core](https://github.com/openiddict/openiddict-core) and some ideas taken from [Myrmex/oid-credentials-mongo](https://github.com/Myrmex/oid-credentials-mongo)

## Run

- install docker
- run mongo image ```docker run -d --name mongodb -p 27017:27017 mongo```
- build and run ```./OpeniddictSamples.sln```

## Framework and libriries

- ```net5.0```
- ```OpenIddict.*``` - ```3.0.0```
- ```AspNetCore.Identity.MongoDbCore``` - ```2.1.1```
