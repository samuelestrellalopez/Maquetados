const marvel = {
  renderData: (data) => {
    const container = document.querySelector('#data-row');
    let contentHTML = '';

    for (const item of data) {
      let urlItem = item.urls[0].url;
      let description = '';

      if (item.description) {
        description = item.description;
      } else if (item.textObjects && item.textObjects.length > 0) {
        description = item.textObjects[0].text;
      } else {
        description = 'No description available';
      }

      contentHTML += `
        <div class="col-md-4">
          <a href="${urlItem}" target="_blank">
            <img src="${item.thumbnail.path}.${item.thumbnail.extension}" alt="${item.title}" class="img-thumbnail">
          </a>
          <div class="text-center">
            <h3 class="bg-light">${item.title}
              <div class="d-flex justify-content-center align-items-center">
                <button class="btn btn-primary mb-2" data-bs-toggle="modal" data-bs-target="#descriptionModal-${item.id}">Read more...</button>
              </div>
            </h3>
          </div>
          <div class="modal fade" id="descriptionModal-${item.id}" tabindex="-1" aria-labelledby="descriptionModalLabel-${item.id}" aria-hidden="true">
            <div class="modal-dialog modal-dialog-scrollable">
              <div class="modal-content">
                <div class="modal-header">
                  <h5 class="modal-title" id="descriptionModalLabel-${item.id}">Description</h5>
                  <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body description-modal-body">
                  <h3 class="modal-title">${item.title}</h3>
                  <p>${description}</p>
                </div>
              </div>
            </div>
          </div>
        </div>`;
    }

    container.innerHTML = contentHTML;
  },

  renderHome: () => {
    const container = document.querySelector('#data-row');
    container.innerHTML = '';

    const homeContent = document.getElementById('home-content');
    homeContent.style.display = 'block';

    const comicsContent = document.getElementById('comics-content');
    if (comicsContent) {
      comicsContent.style.display = 'none';
    }
    const eventsContent = document.getElementById('events-content');
    if (eventsContent) {
      eventsContent.style.display = 'none';
    }
    const heroContent = document.getElementById('hero-content');
    if (heroContent) {
      heroContent.style.display = 'none';
    }
  },

  renderAll: () => {
    const comicsUrlAPI = 'https://gateway.marvel.com:443/v1/public/comics?ts=1&apikey=f3f6793c3912050b6388202d19234f35&hash=e3e63ce7ddf92d1719ab138410bd5b0d';
    const eventsUrlAPI = 'https://gateway.marvel.com:443/v1/public/events?ts=1&apikey=f3f6793c3912050b6388202d19234f35&hash=e3e63ce7ddf92d1719ab138410bd5b0d';
    const herosUrlAPI = 'https://gateway.marvel.com:443/v1/public/characters?ts=1&apikey=f3f6793c3912050b6388202d19234f35&hash=e3e63ce7ddf92d1719ab138410bd5b0d';
  
    const fetchComics = fetch(comicsUrlAPI).then(res => res.json());
    const fetchEvents = fetch(eventsUrlAPI).then(res => res.json());
    const fetchHeros = fetch(herosUrlAPI).then(res => res.json());
  
    Promise.all([fetchComics, fetchEvents, fetchHeros])
      .then(([comicsJson, eventsJson, herosJson]) => {
        const comics = comicsJson.data.results;
        const events = eventsJson.data.results;
        const heros = herosJson.data.results;
  
        const allData = [...comics, ...events, ...heros];
        marvel.renderData(allData);
  
        const container = document.querySelector('#data-row');
        let contentHTML = '';
  
        for (const item of allData) {
          let urlItem = item.urls[0].url;
          let description = '';
  
          if (item.description) {
            description = item.description;
          } else if (item.textObjects && item.textObjects.length > 0) {
            description = item.textObjects[0].text;
          } else {
            description = 'No description available';
          }
  
          let itemType = '';
          let comicsHTML = '';
          let seriesHTML = '';
  
          if (heros.includes(item)) {
            itemType = 'Hero';
            if (item.description) {
              description = item.description;
            } else {
              description = 'No description available';
            }
            comicsHTML = item.comics.items.length > 0 ? item.comics.items.map(comic => `<p>${comic.name}</p>`).join('') : '<p>No comics available</p>';
            seriesHTML = item.series.items.length > 0 ? item.series.items.map(series => `<p>${series.name}</p>`).join('') : '<p>No series available</p>';
          } else if (comics.includes(item)) {
            itemType = 'Comic';
          } else if (events.includes(item)) {
            itemType = 'Event';
          }
          
  
          contentHTML += `
            <div class="col-md-4">
              <a href="${urlItem}" target="_blank">
                <img src="${item.thumbnail.path}.${item.thumbnail.extension}" alt="${item.title || item.name}" class="img-thumbnail">
              </a>
              <div class="text-center">
                <h3 class="bg-light">${item.title || item.name}
                  <div class="d-flex justify-content-center align-items-center">
                    <button class="btn btn-primary mb-2" data-bs-toggle="modal" data-bs-target="#descriptionModal-${item.id}">Read more...</button>
                  </div>
                </h3>
              </div>
              <div class="modal fade" id="descriptionModal-${item.id}" tabindex="-1" aria-labelledby="descriptionModalLabel-${item.id}" aria-hidden="true">
                <div class="modal-dialog modal-dialog-scrollable">
                  <div class="modal-content">
                    <div class="modal-header">
                      <h5 class="modal-title" id="descriptionModalLabel-${item.id}">Description</h5>
                      <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body description-modal-body">
                      <h3 class="modal-title">${item.title || item.name}</h3>
                      <p>${description}</p>
                      ${itemType === 'Hero' ? `
                        <h5>Comics:</h5><br>
                        <p>${comicsHTML}</p>
                        <h5>Series:</h5><br>
                        <p>${seriesHTML}</p>
                      ` : ''}
                    </div>
                  </div>
                </div>
              </div>
            </div>`;
        }
  
        container.innerHTML = contentHTML;
      })
      .catch(error => console.log(error));
  },
  
  
  
  renderEvents: () => {
    const eventsUrlAPI = 'https://gateway.marvel.com:443/v1/public/events?ts=1&apikey=f3f6793c3912050b6388202d19234f35&hash=e3e63ce7ddf92d1719ab138410bd5b0d';

    fetch(eventsUrlAPI)
      .then(res => res.json())
      .then((json) => {
        const events = json.data.results.map((event) => {
          let description = '';

          if (event.description) {
            description = event.description;
          } else if (event.textObjects && event.textObjects.length > 0) {
            description = event.textObjects[0].text;
          } else {
            description = 'No description available';
          }

          event.description = description;
          return event;
        });
        marvel.renderData(events);
      })
      .catch(error => console.log(error));
  },  renderComics: () => {
    const comicsUrlAPI = 'https://gateway.marvel.com:443/v1/public/comics?ts=1&apikey=f3f6793c3912050b6388202d19234f35&hash=e3e63ce7ddf92d1719ab138410bd5b0d';

    fetch(comicsUrlAPI)
      .then(res => res.json())
      .then((json) => {
        const comics = json.data.results.map((comic) => {
          let description = '';

          if (comic.description) {
            description = comic.description;
          } else if (comic.textObjects && comic.textObjects.length > 0) {
            description = comic.textObjects[0].text;
          } else {
            description = 'No description available';
          }

          comic.description = description;
          return comic;
        });
        marvel.renderData(comics);
      })
      .catch(error => console.log(error));
  },
  renderHeros: () => {
    const herosUrlAPI = 'https://gateway.marvel.com:443/v1/public/characters?ts=1&apikey=f3f6793c3912050b6388202d19234f35&hash=e3e63ce7ddf92d1719ab138410bd5b0d';
  
    fetch(herosUrlAPI)
      .then(res => res.json())
      .then((json) => {
        const heros = json.data.results.map((hero) => {
          let description = '';
  
          if (hero.description) {
            description = hero.description;
          } else if (hero.textObjects && hero.textObjects.length > 0) {
            description = hero.textObjects[0].text;
          } else {
            description = 'No description available';
          }
  
          hero.description = description;
          return hero;
        });
  
        const container = document.querySelector('#data-row');
        let contentHTML = '';
  
        for (const hero of heros) {
          let urlItem = hero.urls[0].url;
          let description = hero.description;
          let name = hero.name;
  
          let comics = hero.comics.items;
          let series = hero.series.items;
  
          let comicsHTML = '';
          let seriesHTML = '';
  
          if (comics.length > 0) {
            comicsHTML = comics.map(comic => `<p>${comic.name}</p>`).join('');
          } else {
            comicsHTML = '<p>No comics available</p>';
          }
  
          if (series.length > 0) {
            seriesHTML = series.map(series => `<p>${series.name}</p>`).join('');
          } else {
            seriesHTML = '<p>No series available</p>';
          }
  
          contentHTML += `
            <div class="col-md-4">
              <a href="${urlItem}" target="_blank">
                <img src="${hero.thumbnail.path}.${hero.thumbnail.extension}" alt="${hero.name}" class="img-thumbnail">
              </a>
              <div class="text-center">
                <h3 class="bg-light">${name}
                  <div class="d-flex justify-content-center align-items-center">
                    <button class="btn btn-primary mb-2" data-bs-toggle="modal" data-bs-target="#descriptionModal-${hero.id}">Read more...</button>
                  </div>
                </h3>
              </div>
              <div class="modal fade" id="descriptionModal-${hero.id}" tabindex="-1" aria-labelledby="descriptionModalLabel-${hero.id}" aria-hidden="true">
                <div class="modal-dialog modal-dialog-scrollable">
                  <div class="modal-content">
                    <div class="modal-header">
                      <h5 class="modal-title" id="descriptionModalLabel-${hero.id}">Description</h5>
                      <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body description-modal-body">
                      <h3 class="modal-title">${name}</h3>
                      <p>${description}</p>
                      <h5>Comics:</h5><br>
                      <p>
                        ${comicsHTML}
                      </p>
                      <h5>Series:</h5><br>
                      <p>
                        ${seriesHTML}
                      </p>
                    </div>
                  </div>
                </div>
              </div>
            </div>`;
        }
  
        container.innerHTML = contentHTML;
      })
      .catch(error => console.log(error));
  },
};

marvel.renderAll();

document.getElementById("home-link").addEventListener("click", () => {
  marvel.renderHome();
});

document.getElementById("all-link").addEventListener("click", () => {
  marvel.renderAll();
});

document.getElementById("events-link").addEventListener("click", () => {
  marvel.renderEvents();
});

document.getElementById("comics-link").addEventListener("click", () => {
  marvel.renderComics();
});

document.getElementById("hero-link").addEventListener("click", () => {
  marvel.renderHeros();
});
