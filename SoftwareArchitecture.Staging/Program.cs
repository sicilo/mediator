using SoftwareArchitecture.DesignPatterns.Mediator.Colleagues;
using SoftwareArchitecture.DesignPatterns.Mediator.Mediators;

ChatMediator mediator = new();

ChatUserCollegue estefania = mediator.CreateUser("Estefania");
ChatUserCollegue camilo = mediator.CreateUser("Camilo");
ChatUserCollegue juan = mediator.CreateUser("Juan");


estefania.SendMessage("Milo, que haces?", camilo.Id);
camilo.SendMessage("Preparando un examen, tu ?", estefania.Id);
estefania.SendMessage("Preparando un examen de ingles, me ayudas?", camilo.Id);
camilo.SendMessage("Mmm.. ahora no puedo pero, voy a hablar con un amigo", estefania.Id);
camilo.SendMessage("Habla ingles y seguro te puede ayudar, que dices ?", estefania.Id);
estefania.SendMessage("Va, pero preguntale cuanto me cobra primero", camilo.Id);
camilo.SendMessage("Ok", estefania.Id);

camilo.SendMessage("Hi Juan, are U doing?", juan.Id);
juan.SendMessage("Working man, 'til it's 5 pm, and U?", camilo.Id);



