
export function onPictureError() {
    console.log(this);
    this.onerror = null;
    // 240 AVIF
    this.parentNode.children[0].srcset = this.src;
    this.parentNode.children[0].type = 'image/png';
    // 480 AVIF
    this.parentNode.children[1].srcset = this.src;
    this.parentNode.children[1].type = 'image/png';
    // 720 AVIF
    this.parentNode.children[2].srcset = this.src;
    this.parentNode.children[2].type = 'image/png';
    // Largest AVIF
    this.parentNode.children[3].srcset = this.src;
    this.parentNode.children[3].type = 'image/png';
}

(function () {
  "use strict";

  /**
   * Apply .scrolled class to the body as the page is scrolled down
   */
  function toggleScrolled() {
    const selectBody = document.querySelector('body');
    const selectHeader = document.querySelector('#header');
    if (!selectHeader.classList.contains('scroll-up-sticky') && !selectHeader.classList.contains('sticky-top') && !selectHeader.classList.contains('fixed-top')) return;
    window.scrollY > 100 ? selectBody.classList.add('scrolled') : selectBody.classList.remove('scrolled');
  }

  document.addEventListener('scroll', toggleScrolled);
  window.addEventListener('load', toggleScrolled);

  /**
   * Hide mobile nav on same-page/hash links
   */
  const menuToggle = document.getElementById('navbarNav')
  document.querySelectorAll('#navbarNav a').forEach(navItem => {
    navItem.addEventListener('click', () => {
      if (menuToggle.classList.contains('show') && !navItem.classList.contains('dropdown-toggle')) {
        menuToggle.classList.remove('show');
      }
    });

  });

  /**
   * Scroll top button
   */
  let scrollTop = document.querySelector('.scroll-top');

  function toggleScrollTop() {
    if (scrollTop) {
      window.scrollY > 100 ? scrollTop.classList.add('active') : scrollTop.classList.remove('active');
    }
  }
  scrollTop.addEventListener('click', (e) => {
    e.preventDefault();
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    });
  });

  window.addEventListener('load', toggleScrollTop);
  document.addEventListener('scroll', toggleScrollTop);

  /**
   * Animation on scroll function and init
   */
  // function aosInit() {
  //   AOS.init({
  //     duration: 600,
  //     easing: 'ease-in-out',
  //     once: true,
  //     mirror: false
  //   });
  // }
  // window.addEventListener('load', aosInit);

  /**
   * Initiate glightbox
   */
  const glightbox = GLightbox({
    selector: '.glightbox'
  });

  /**
   * Initiate Pure Counter
   */
  //new PureCounter();

  /**
   * Init swiper sliders
   */
  //function initSwiper() {
  //  document.querySelectorAll(".init-swiper").forEach(function(swiperElement) {
  //    let config = JSON.parse(
  //      swiperElement.querySelector(".swiper-config").innerHTML.trim()
  //    );

  //    if (swiperElement.classList.contains("swiper-tab")) {
  //      initSwiperWithCustomPagination(swiperElement, config);
  //    } else {
  //      new Swiper(swiperElement, config);
  //    }
  //  });
  //}

  //window.addEventListener("load", initSwiper);

  /**
   * Init isotope layout and filters
   */
  //document.querySelectorAll('.isotope-layout').forEach(function(isotopeItem) {
  //  let layout = isotopeItem.getAttribute('data-layout') ?? 'masonry';
  //  let filter = isotopeItem.getAttribute('data-default-filter') ?? '*';
  //  let sort = isotopeItem.getAttribute('data-sort') ?? 'original-order';

  //  let initIsotope;
  //  imagesLoaded(isotopeItem.querySelector('.isotope-container'), function() {
  //    initIsotope = new Isotope(isotopeItem.querySelector('.isotope-container'), {
  //      itemSelector: '.isotope-item',
  //      layoutMode: layout,
  //      filter: filter,
  //      sortBy: sort
  //    });
  //  });

  //  isotopeItem.querySelectorAll('.isotope-filters li').forEach(function(filters) {
  //    filters.addEventListener('click', function() {
  //      isotopeItem.querySelector('.isotope-filters .filter-active').classList.remove('filter-active');
  //      this.classList.add('filter-active');
  //      initIsotope.arrange({
  //        filter: this.getAttribute('data-filter')
  //      });
  //      if (typeof aosInit === 'function') {
  //        aosInit();
  //      }
  //    }, false);
  //  });

  //});

  /**
   * Correct scrolling position upon page load for URLs containing hash links.
   */
  window.addEventListener('load', function(e) {
    if (window.location.hash) {
      if (document.querySelector(window.location.hash)) {
        setTimeout(() => {
          let section = document.querySelector(window.location.hash);
          let scrollMarginTop = getComputedStyle(section).scrollMarginTop;
          window.scrollTo({
            top: section.offsetTop - parseInt(scrollMarginTop),
            behavior: 'smooth'
          });
        }, 100);
      }
    }
  });


})();